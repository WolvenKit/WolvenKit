using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIMotionTableProvider : ISerializable
	{
		private CInt32 _id;
		private CInt32 _parentId;
		private CEnum<animMotionTableType> _type;
		private CEnum<animMotionTableAction> _action;
		private CEnum<animParentStaticSwitchBranch> _parentStaticSwitchBranch;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public CInt32 ParentId
		{
			get => GetProperty(ref _parentId);
			set => SetProperty(ref _parentId, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<animMotionTableType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<animMotionTableAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(4)] 
		[RED("parentStaticSwitchBranch")] 
		public CEnum<animParentStaticSwitchBranch> ParentStaticSwitchBranch
		{
			get => GetProperty(ref _parentStaticSwitchBranch);
			set => SetProperty(ref _parentStaticSwitchBranch, value);
		}

		public animIMotionTableProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
