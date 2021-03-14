using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStimTag : AIbehaviorconditionScript
	{
		private CArray<CName> _stimTagToCompare;

		[Ordinal(0)] 
		[RED("stimTagToCompare")] 
		public CArray<CName> StimTagToCompare
		{
			get
			{
				if (_stimTagToCompare == null)
				{
					_stimTagToCompare = (CArray<CName>) CR2WTypeManager.Create("array:CName", "stimTagToCompare", cr2w, this);
				}
				return _stimTagToCompare;
			}
			set
			{
				if (_stimTagToCompare == value)
				{
					return;
				}
				_stimTagToCompare = value;
				PropertySet(this);
			}
		}

		public CheckStimTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
