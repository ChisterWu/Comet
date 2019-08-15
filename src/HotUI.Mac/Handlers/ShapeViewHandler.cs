﻿

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Comet.Mac.Handlers
{
    public class ShapeViewHandler : AbstractControlHandler<ShapeView,
        HUIShapeView>
    {
        public static readonly PropertyMapper<ShapeView> Mapper = new PropertyMapper<ShapeView>(ViewHandler.Mapper)
        {
            [nameof(Comet.ShapeView.Shape)] = MapShapeProperty,
        };

        
		public ShapeViewHandler() : base(Mapper)
		{

        }

        protected override HUIShapeView CreateView() => new HUIShapeView();

        protected override void DisposeView(HUIShapeView nativeView)
        {
            
        }

        public static void MapShapeProperty(IViewHandler viewHandler, ShapeView virtualView)
        {
            var nativeView = (HUIShapeView) viewHandler.NativeView;
            nativeView.Shape = virtualView.Shape;
            nativeView.View = virtualView;

        }
    }
}