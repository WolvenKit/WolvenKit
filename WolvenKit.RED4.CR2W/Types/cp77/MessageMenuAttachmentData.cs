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
			get
			{
				if (_entryHash == null)
				{
					_entryHash = (CInt32) CR2WTypeManager.Create("Int32", "entryHash", cr2w, this);
				}
				return _entryHash;
			}
			set
			{
				if (_entryHash == value)
				{
					return;
				}
				_entryHash = value;
				PropertySet(this);
			}
		}

		public MessageMenuAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
