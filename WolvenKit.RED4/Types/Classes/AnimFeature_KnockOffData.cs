using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_KnockOffData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("knockedOff")] 
		public CBool KnockedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CFloat Force
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("draggedOff")] 
		public CBool DraggedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_KnockOffData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
