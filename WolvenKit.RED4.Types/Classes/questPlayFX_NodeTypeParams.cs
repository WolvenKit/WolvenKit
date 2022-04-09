using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayFX_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("play")] 
		public CBool Play
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questPlayFX_NodeTypeParams()
		{
			Play = true;
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
