using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CommandSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] 
		[RED("track")] 
		public CBool Track
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("commandClassNames")] 
		public CArray<CName> CommandClassNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public CommandSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
