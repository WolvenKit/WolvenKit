using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedLookAtData : RedBaseClass
	{
		private netTime _creationNetTime;

		[Ordinal(0)] 
		[RED("creationNetTime")] 
		public netTime CreationNetTime
		{
			get => GetProperty(ref _creationNetTime);
			set => SetProperty(ref _creationNetTime, value);
		}
	}
}
