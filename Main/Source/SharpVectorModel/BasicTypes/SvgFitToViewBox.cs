using System;
using System.Xml;

namespace SharpVectors.Dom.Svg
{
    public class SvgFitToViewBox : ISvgFitToViewBox
	{
        #region Private Fields

        private ISvgAnimatedRect _viewBox;
        private ISvgAnimatedPreserveAspectRatio _preserveAspectRatio;

        protected SvgElement _ownerElement;

        #endregion

        #region Constructors and Destructor

        public SvgFitToViewBox(SvgElement ownerElement)
        {
            _ownerElement = ownerElement;
            _ownerElement.attributeChangeHandler += OnAttributeChange;
        }

        #endregion

        #region ISvgFitToViewBox Members

        public ISvgAnimatedRect ViewBox
        {
            get {
                if (_viewBox == null)
                {
                    string attr = _ownerElement.GetAttribute("viewBox").Trim();
                    if (string.IsNullOrWhiteSpace(attr))
                    {
                        double x = 0;
                        double y = 0;
                        double width = 0;
                        double height = 0;
                        if (_ownerElement is SvgSvgElement)
                        {
                            SvgSvgElement svgSvgElm = _ownerElement as SvgSvgElement;

                            x = svgSvgElm.X.AnimVal.Value;
                            y = svgSvgElm.Y.AnimVal.Value;
                            width = svgSvgElm.Width.AnimVal.Value;
                            height = svgSvgElm.Height.AnimVal.Value;
                        }
                        _viewBox = new SvgAnimatedRect(new SvgRect(x, y, width, height));
                    }
                    else
                    {
                        _viewBox = new SvgAnimatedRect(attr);
                    }
                }

                return _viewBox;
            }
        }

        public ISvgAnimatedPreserveAspectRatio PreserveAspectRatio
        {
            get {
                if (_preserveAspectRatio == null)
                {
                    _preserveAspectRatio = new SvgAnimatedPreserveAspectRatio(
                        _ownerElement.GetAttribute("preserveAspectRatio"), _ownerElement);
                }
                return _preserveAspectRatio;
            }
        }

        #endregion

        #region Update handling

        private void OnAttributeChange(Object src, XmlNodeChangedEventArgs args)
		{
			XmlAttribute attribute = src as XmlAttribute;

			if (attribute.NamespaceURI.Length == 0)
			{
				switch (attribute.LocalName)
				{
					case "viewBox":
						_viewBox = null;
						break;
					case "preserveAspectRatio":
						_preserveAspectRatio = null;
						break;
				}
			}
		}

		#endregion
	}
}
