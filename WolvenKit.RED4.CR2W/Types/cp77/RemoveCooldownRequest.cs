using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveCooldownRequest : gameScriptableSystemRequest
	{
		private CInt32 _cid;

		[Ordinal(0)] 
		[RED("cid")] 
		public CInt32 Cid
		{
			get => GetProperty(ref _cid);
			set => SetProperty(ref _cid, value);
		}

		public RemoveCooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
