using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldEnvironmentAreaParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("globalLight")] 
		public worldWorldGlobalLightParameters GlobalLight
		{
			get => GetPropertyValue<worldWorldGlobalLightParameters>();
			set => SetPropertyValue<worldWorldGlobalLightParameters>(value);
		}

		public worldWorldEnvironmentAreaParameters()
		{
			GlobalLight = new() { Unit = Enums.ELightUnit.LU_Lux };
		}
	}
}
