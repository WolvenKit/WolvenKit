using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageMenuAttachmentData : IScriptable
	{
		private CInt32 _entryHash;

		[Ordinal(0)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}

		public MessageMenuAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
