using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workLookAtDrivenTurn : workIEntry
	{
		[Ordinal(2)] 
		[RED("turnAngle")] 
		public CInt32 TurnAngle
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("turnAnimName")] 
		public CName TurnAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public workLookAtDrivenTurn()
		{
			Id = new() { Id = 4294967295 };
			Flags = 512;
			BlendTime = 0.500000F;
		}
	}
}
