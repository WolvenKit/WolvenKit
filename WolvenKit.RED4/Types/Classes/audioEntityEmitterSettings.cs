using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEntityEmitterSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("emitterDecorators")] 
		public CArray<CName> EmitterDecorators
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isObjectPerPositionEmitter")] 
		public CBool IsObjectPerPositionEmitter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioEntityEmitterSettings()
		{
			EmitterDecorators = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
