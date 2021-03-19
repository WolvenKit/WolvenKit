using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeVisualEvent : redEvent
	{
		private TweakDBID _group;
		private CName _changedModule;
		private CBool _activated;
		private CName _meshComponentName;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("group")] 
		public TweakDBID Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(1)] 
		[RED("changedModule")] 
		public CName ChangedModule
		{
			get => GetProperty(ref _changedModule);
			set => SetProperty(ref _changedModule, value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}

		[Ordinal(3)] 
		[RED("meshComponentName")] 
		public CName MeshComponentName
		{
			get => GetProperty(ref _meshComponentName);
			set => SetProperty(ref _meshComponentName, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameVisionModeVisualEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
