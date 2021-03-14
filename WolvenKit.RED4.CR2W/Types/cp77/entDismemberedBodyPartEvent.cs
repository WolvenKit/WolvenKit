using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDismemberedBodyPartEvent : redEvent
	{
		private CStatic<CName> _bones;

		[Ordinal(0)] 
		[RED("bones", 32)] 
		public CStatic<CName> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CStatic<CName>) CR2WTypeManager.Create("static:32,CName", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		public entDismemberedBodyPartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
