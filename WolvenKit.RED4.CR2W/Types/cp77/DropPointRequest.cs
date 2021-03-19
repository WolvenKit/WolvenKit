using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointRequest : gameScriptableSystemRequest
	{
		private TweakDBID _record;
		private CEnum<DropPointPackageStatus> _status;
		private gamePersistentID _holder;

		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<DropPointPackageStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("holder")] 
		public gamePersistentID Holder
		{
			get => GetProperty(ref _holder);
			set => SetProperty(ref _holder, value);
		}

		public DropPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
