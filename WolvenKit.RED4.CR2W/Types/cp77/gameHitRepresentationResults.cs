using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResults : CVariable
	{
		private CArray<gameHitRepresentationResult> _sults;

		[Ordinal(0)] 
		[RED("sults")] 
		public CArray<gameHitRepresentationResult> Sults
		{
			get
			{
				if (_sults == null)
				{
					_sults = (CArray<gameHitRepresentationResult>) CR2WTypeManager.Create("array:gameHitRepresentationResult", "sults", cr2w, this);
				}
				return _sults;
			}
			set
			{
				if (_sults == value)
				{
					return;
				}
				_sults = value;
				PropertySet(this);
			}
		}

		public gameHitRepresentationResults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
