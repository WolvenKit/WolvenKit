using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tempshitMapPinManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CName _mapPinName;
		private CEnum<tempshitMapPinOperation> _operation;
		private gameEntityReference _nodeRef;
		private Vector3 _position;
		private LocalizationString _forceCaption;

		[Ordinal(2)] 
		[RED("mapPinName")] 
		public CName MapPinName
		{
			get => GetProperty(ref _mapPinName);
			set => SetProperty(ref _mapPinName, value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<tempshitMapPinOperation> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public gameEntityReference NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(5)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(6)] 
		[RED("forceCaption")] 
		public LocalizationString ForceCaption
		{
			get => GetProperty(ref _forceCaption);
			set => SetProperty(ref _forceCaption, value);
		}

		public tempshitMapPinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
