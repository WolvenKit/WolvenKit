using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneId : CVariable
	{
		private CUInt64 _resPathHash;

		[Ordinal(0)] 
		[RED("resPathHash")] 
		public CUInt64 ResPathHash
		{
			get
			{
				if (_resPathHash == null)
				{
					_resPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "resPathHash", cr2w, this);
				}
				return _resPathHash;
			}
			set
			{
				if (_resPathHash == value)
				{
					return;
				}
				_resPathHash = value;
				PropertySet(this);
			}
		}

		public scnSceneId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
