using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardSerializableID : CVariable
	{
		private CName _blackboardName;
		private CName _fieldName;

		[Ordinal(0)] 
		[RED("blackboardName")] 
		public CName BlackboardName
		{
			get => GetProperty(ref _blackboardName);
			set => SetProperty(ref _blackboardName, value);
		}

		[Ordinal(1)] 
		[RED("fieldName")] 
		public CName FieldName
		{
			get => GetProperty(ref _fieldName);
			set => SetProperty(ref _fieldName, value);
		}

		public gameBlackboardSerializableID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
