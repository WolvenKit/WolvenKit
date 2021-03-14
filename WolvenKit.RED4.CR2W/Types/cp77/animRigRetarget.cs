using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigRetarget : CVariable
	{
		private rRef<animRig> _sourceRig;

		[Ordinal(0)] 
		[RED("sourceRig")] 
		public rRef<animRig> SourceRig
		{
			get
			{
				if (_sourceRig == null)
				{
					_sourceRig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "sourceRig", cr2w, this);
				}
				return _sourceRig;
			}
			set
			{
				if (_sourceRig == value)
				{
					return;
				}
				_sourceRig = value;
				PropertySet(this);
			}
		}

		public animRigRetarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
