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
			get
			{
				if (_cid == null)
				{
					_cid = (CInt32) CR2WTypeManager.Create("Int32", "cid", cr2w, this);
				}
				return _cid;
			}
			set
			{
				if (_cid == value)
				{
					return;
				}
				_cid = value;
				PropertySet(this);
			}
		}

		public RemoveCooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
