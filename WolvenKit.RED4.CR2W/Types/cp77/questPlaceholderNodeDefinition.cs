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
			get => GetProperty(ref _replacedNodeClassName);
			set => SetProperty(ref _replacedNodeClassName, value);
		}

		[Ordinal(3)] 
		[RED("copiedSockets")] 
		public CArray<questPlaceholderNodeSocketInfo> CopiedSockets
		{
			get => GetProperty(ref _copiedSockets);
			set => SetProperty(ref _copiedSockets, value);
		}

		[Ordinal(4)] 
		[RED("clipboardHolder")] 
		public CHandle<ISerializable> ClipboardHolder
		{
			get => GetProperty(ref _clipboardHolder);
			set => SetProperty(ref _clipboardHolder, value);
		}

		public questPlaceholderNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
