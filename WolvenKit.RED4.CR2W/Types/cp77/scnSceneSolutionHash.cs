using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHash : CVariable
	{
		private scnSceneSolutionHashHash _sceneSolutionHash;

		[Ordinal(0)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHashHash SceneSolutionHash
		{
			get
			{
				if (_sceneSolutionHash == null)
				{
					_sceneSolutionHash = (scnSceneSolutionHashHash) CR2WTypeManager.Create("scnSceneSolutionHashHash", "sceneSolutionHash", cr2w, this);
				}
				return _sceneSolutionHash;
			}
			set
			{
				if (_sceneSolutionHash == value)
				{
					return;
				}
				_sceneSolutionHash = value;
				PropertySet(this);
			}
		}

		public scnSceneSolutionHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
