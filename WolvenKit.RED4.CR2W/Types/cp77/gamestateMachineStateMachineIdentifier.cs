using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineIdentifier : CVariable
	{
		private CName _definitionName;
		private CName _referenceName;

		[Ordinal(0)] 
		[RED("definitionName")] 
		public CName DefinitionName
		{
			get
			{
				if (_definitionName == null)
				{
					_definitionName = (CName) CR2WTypeManager.Create("CName", "definitionName", cr2w, this);
				}
				return _definitionName;
			}
			set
			{
				if (_definitionName == value)
				{
					return;
				}
				_definitionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get
			{
				if (_referenceName == null)
				{
					_referenceName = (CName) CR2WTypeManager.Create("CName", "referenceName", cr2w, this);
				}
				return _referenceName;
			}
			set
			{
				if (_referenceName == value)
				{
					return;
				}
				_referenceName = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateMachineIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
