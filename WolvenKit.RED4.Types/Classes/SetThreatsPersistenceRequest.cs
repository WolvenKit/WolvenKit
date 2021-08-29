using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetThreatsPersistenceRequest : AIAIEvent
	{
		private CWeakHandle<entEntity> _et;
		private CBool _isPersistent;

		[Ordinal(2)] 
		[RED("et")] 
		public CWeakHandle<entEntity> Et
		{
			get => GetProperty(ref _et);
			set => SetProperty(ref _et, value);
		}

		[Ordinal(3)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}
	}
}
