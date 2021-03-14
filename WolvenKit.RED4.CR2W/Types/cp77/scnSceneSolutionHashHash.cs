using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHashHash : CVariable
	{
		private CUInt64 _sceneSolutionHashDate;

		[Ordinal(0)] 
		[RED("sceneSolutionHashDate")] 
		public CUInt64 SceneSolutionHashDate
		{
			get
			{
				if (_sceneSolutionHashDate == null)
				{
					_sceneSolutionHashDate = (CUInt64) CR2WTypeManager.Create("Uint64", "sceneSolutionHashDate", cr2w, this);
				}
				return _sceneSolutionHashDate;
			}
			set
			{
				if (_sceneSolutionHashDate == value)
				{
					return;
				}
				_sceneSolutionHashDate = value;
				PropertySet(this);
			}
		}

		public scnSceneSolutionHashHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
