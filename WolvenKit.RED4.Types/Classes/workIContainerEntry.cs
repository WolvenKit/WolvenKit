using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIContainerEntry : workIEntry
	{
		private CArray<CHandle<workIEntry>> _list;
		private CName _idleAnim;

		[Ordinal(2)] 
		[RED("list")] 
		public CArray<CHandle<workIEntry>> List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get => GetProperty(ref _idleAnim);
			set => SetProperty(ref _idleAnim, value);
		}
	}
}
