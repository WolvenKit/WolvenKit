using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageThreadReadEvent : redEvent
	{
		private CInt32 _parentHash;

		[Ordinal(0)] 
		[RED("parentHash")] 
		public CInt32 ParentHash
		{
			get => GetProperty(ref _parentHash);
			set => SetProperty(ref _parentHash, value);
		}

		public MessageThreadReadEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
