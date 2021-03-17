using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponent : gameScriptableComponent
	{
		private EntityAttachementData _parentAttachementData;

		[Ordinal(5)] 
		[RED("parentAttachementData")] 
		public EntityAttachementData ParentAttachementData
		{
			get => GetProperty(ref _parentAttachementData);
			set => SetProperty(ref _parentAttachementData, value);
		}

		public EntityAttachementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
