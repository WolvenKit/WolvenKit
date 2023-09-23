using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectableObjectComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isFinished")] 
		public CBool IsFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("listeners")] 
		public CArray<CHandle<questObjectInspectListener>> Listeners
		{
			get => GetPropertyValue<CArray<CHandle<questObjectInspectListener>>>();
			set => SetPropertyValue<CArray<CHandle<questObjectInspectListener>>>(value);
		}

		public InspectableObjectComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
