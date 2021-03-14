using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlaceholderNodeDefinition : questDisableableNodeDefinition
	{
		private CName _replacedNodeClassName;
		private CArray<questPlaceholderNodeSocketInfo> _copiedSockets;
		private CHandle<ISerializable> _clipboardHolder;

		[Ordinal(2)] 
		[RED("replacedNodeClassName")] 
		public CName ReplacedNodeClassName
		{
			get
			{
				if (_replacedNodeClassName == null)
				{
					_replacedNodeClassName = (CName) CR2WTypeManager.Create("CName", "replacedNodeClassName", cr2w, this);
				}
				return _replacedNodeClassName;
			}
			set
			{
				if (_replacedNodeClassName == value)
				{
					return;
				}
				_replacedNodeClassName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("copiedSockets")] 
		public CArray<questPlaceholderNodeSocketInfo> CopiedSockets
		{
			get
			{
				if (_copiedSockets == null)
				{
					_copiedSockets = (CArray<questPlaceholderNodeSocketInfo>) CR2WTypeManager.Create("array:questPlaceholderNodeSocketInfo", "copiedSockets", cr2w, this);
				}
				return _copiedSockets;
			}
			set
			{
				if (_copiedSockets == value)
				{
					return;
				}
				_copiedSockets = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("clipboardHolder")] 
		public CHandle<ISerializable> ClipboardHolder
		{
			get
			{
				if (_clipboardHolder == null)
				{
					_clipboardHolder = (CHandle<ISerializable>) CR2WTypeManager.Create("handle:ISerializable", "clipboardHolder", cr2w, this);
				}
				return _clipboardHolder;
			}
			set
			{
				if (_clipboardHolder == value)
				{
					return;
				}
				_clipboardHolder = value;
				PropertySet(this);
			}
		}

		public questPlaceholderNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
