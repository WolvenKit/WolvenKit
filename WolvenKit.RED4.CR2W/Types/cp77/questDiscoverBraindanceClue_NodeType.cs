using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDiscoverBraindanceClue_NodeType : questIUIManagerNodeType
	{
		private CName _clueName;

		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get
			{
				if (_clueName == null)
				{
					_clueName = (CName) CR2WTypeManager.Create("CName", "clueName", cr2w, this);
				}
				return _clueName;
			}
			set
			{
				if (_clueName == value)
				{
					return;
				}
				_clueName = value;
				PropertySet(this);
			}
		}

		public questDiscoverBraindanceClue_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
