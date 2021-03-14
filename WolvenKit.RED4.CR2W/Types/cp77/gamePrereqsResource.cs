using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqsResource : CResource
	{
		private CArray<gamePrereqDefinition> _prereqs;

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<gamePrereqDefinition> Prereqs
		{
			get
			{
				if (_prereqs == null)
				{
					_prereqs = (CArray<gamePrereqDefinition>) CR2WTypeManager.Create("array:gamePrereqDefinition", "prereqs", cr2w, this);
				}
				return _prereqs;
			}
			set
			{
				if (_prereqs == value)
				{
					return;
				}
				_prereqs = value;
				PropertySet(this);
			}
		}

		public gamePrereqsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
