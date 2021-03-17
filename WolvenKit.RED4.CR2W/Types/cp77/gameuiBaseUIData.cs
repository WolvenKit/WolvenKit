using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseUIData : CVariable
	{
		private CInt64 _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public gameuiBaseUIData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
