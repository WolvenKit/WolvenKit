using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedebugFailure : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gamedebugFailureId Id
		{
			get => GetPropertyValue<gamedebugFailureId>();
			set => SetPropertyValue<gamedebugFailureId>(value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("path")] 
		public gameDebugPath Path
		{
			get => GetPropertyValue<gameDebugPath>();
			set => SetPropertyValue<gameDebugPath>(value);
		}

		[Ordinal(4)] 
		[RED("previous")] 
		public CHandle<gamedebugFailure> Previous
		{
			get => GetPropertyValue<CHandle<gamedebugFailure>>();
			set => SetPropertyValue<CHandle<gamedebugFailure>>(value);
		}

		[Ordinal(5)] 
		[RED("cause")] 
		public CHandle<gamedebugFailure> Cause
		{
			get => GetPropertyValue<CHandle<gamedebugFailure>>();
			set => SetPropertyValue<CHandle<gamedebugFailure>>(value);
		}

		public gamedebugFailure()
		{
			Id = new gamedebugFailureId();
			Path = new gameDebugPath();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
