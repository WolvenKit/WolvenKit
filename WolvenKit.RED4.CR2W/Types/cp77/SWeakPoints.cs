using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWeakPoints : CVariable
	{
		private CName _weakPointName;
		private CString _loc_name_key;
		private CString _loc_desc_key;

		[Ordinal(0)] 
		[RED("weakPointName")] 
		public CName WeakPointName
		{
			get => GetProperty(ref _weakPointName);
			set => SetProperty(ref _weakPointName, value);
		}

		[Ordinal(1)] 
		[RED("loc_name_key")] 
		public CString Loc_name_key
		{
			get => GetProperty(ref _loc_name_key);
			set => SetProperty(ref _loc_name_key, value);
		}

		[Ordinal(2)] 
		[RED("loc_desc_key")] 
		public CString Loc_desc_key
		{
			get => GetProperty(ref _loc_desc_key);
			set => SetProperty(ref _loc_desc_key, value);
		}

		public SWeakPoints(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
