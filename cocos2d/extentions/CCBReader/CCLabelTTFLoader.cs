namespace CocosSharp
{
    internal class CCLabelTTFLoader : CCNodeLoader
    {
        private const string PROPERTY_COLOR = "color";
        private const string PROPERTY_OPACITY = "opacity";
        private const string PROPERTY_BLENDFUNC = "blendFunc";
        private const string PROPERTY_FONTNAME = "fontName";
        private const string PROPERTY_FONTSIZE = "fontSize";
        private const string PROPERTY_HORIZONTALALIGNMENT = "horizontalAlignment";
        private const string PROPERTY_VERTICALALIGNMENT = "verticalAlignment";
        private const string PROPERTY_STRING = "string";
        private const string PROPERTY_DIMENSIONS = "dimensions";

        public override CCNode CreateCCNode()
        {
            return new CCLabelTtf();
        }

        protected override void OnHandlePropTypeColor3(CCNode node, CCNode parent, string propertyName, CCColor3B color, CCBReader reader)
        {
            if (propertyName == PROPERTY_COLOR)
            {
                ((CCLabelTtf) node).Color = color;
            }
            else
            {
                base.OnHandlePropTypeColor3(node, parent, propertyName, color, reader);
            }
        }

        protected override void OnHandlePropTypeByte(CCNode node, CCNode parent, string propertyName, byte pByte, CCBReader reader)
        {
            if (propertyName == PROPERTY_OPACITY)
            {
                ((CCLabelTtf) node).Opacity = pByte;
            }
            else
            {
                base.OnHandlePropTypeByte(node, parent, propertyName, pByte, reader);
            }
        }

        protected override void OnHandlePropTypeBlendFunc(CCNode node, CCNode parent, string propertyName, CCBlendFunc blendFunc,
                                                          CCBReader reader)
        {
            if (propertyName == PROPERTY_BLENDFUNC)
            {
                ((CCLabelTtf) node).BlendFunc = blendFunc;
            }
            else
            {
                base.OnHandlePropTypeBlendFunc(node, parent, propertyName, blendFunc, reader);
            }
        }

        protected override void OnHandlePropTypeFontTTF(CCNode node, CCNode parent, string propertyName, string fontTTF, CCBReader reader)
        {
            if (propertyName == PROPERTY_FONTNAME)
            {
                ((CCLabelTtf) node).FontName = fontTTF;
            }
            else
            {
                base.OnHandlePropTypeFontTTF(node, parent, propertyName, fontTTF, reader);
            }
        }

        protected override void OnHandlePropTypeText(CCNode node, CCNode parent, string propertyName, string pText, CCBReader reader)
        {
            if (propertyName == PROPERTY_STRING)
            {
                ((CCLabelTtf) node).Text = (pText);
            }
            else
            {
                base.OnHandlePropTypeText(node, parent, propertyName, pText, reader);
            }
        }

        protected override void OnHandlePropTypeFloatScale(CCNode node, CCNode parent, string propertyName, float floatScale, CCBReader reader)
        {
            if (propertyName == PROPERTY_FONTSIZE)
            {
                ((CCLabelTtf) node).FontSize = floatScale;
            }
            else
            {
                base.OnHandlePropTypeFloatScale(node, parent, propertyName, floatScale, reader);
            }
        }

        protected override void OnHandlePropTypeIntegerLabeled(CCNode node, CCNode parent, string propertyName, int pIntegerLabeled,
                                                               CCBReader reader)
        {
            if (propertyName == PROPERTY_HORIZONTALALIGNMENT)
            {
                ((CCLabelTtf) node).HorizontalAlignment = (CCTextAlignment)pIntegerLabeled;
            }
            else if (propertyName == PROPERTY_VERTICALALIGNMENT)
            {
                ((CCLabelTtf) node).VerticalAlignment = (CCVerticalTextAlignment)pIntegerLabeled;
            }
            else
            {
                base.OnHandlePropTypeFloatScale(node, parent, propertyName, pIntegerLabeled, reader);
            }
        }

        protected override void OnHandlePropTypeSize(CCNode node, CCNode parent, string propertyName, CCSize pSize, CCBReader reader)
        {
            if (propertyName == PROPERTY_DIMENSIONS)
            {
                ((CCLabelTtf) node).Dimensions = pSize;
            }
            else
            {
                base.OnHandlePropTypeSize(node, parent, propertyName, pSize, reader);
            }
        }
    }
}