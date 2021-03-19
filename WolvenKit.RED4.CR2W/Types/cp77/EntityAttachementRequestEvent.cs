using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementRequestEvent : redEvent
	{
		private EntityAttachementData _attachementData;

		[Ordinal(0)] 
		[RED("attachementData")] 
		public EntityAttachementData AttachementData
		{
			get => GetProperty(ref _attachementData);
			set => SetProperty(ref _attachementData, value);
		}

		public EntityAttachementRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
