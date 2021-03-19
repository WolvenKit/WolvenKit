using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScreenProjectionData : CVariable
	{
		private wCHandle<entEntity> _entity;
		private CName _slotComponentName;
		private CName _slotName;
		private CName _slotFallbackName;
		private Vector4 _staticWorldPosition;
		private Vector4 _fixedWorldOffset;
		private wCHandle<IScriptable> _userData;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("slotComponentName")] 
		public CName SlotComponentName
		{
			get => GetProperty(ref _slotComponentName);
			set => SetProperty(ref _slotComponentName, value);
		}

		[Ordinal(2)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(3)] 
		[RED("slotFallbackName")] 
		public CName SlotFallbackName
		{
			get => GetProperty(ref _slotFallbackName);
			set => SetProperty(ref _slotFallbackName, value);
		}

		[Ordinal(4)] 
		[RED("staticWorldPosition")] 
		public Vector4 StaticWorldPosition
		{
			get => GetProperty(ref _staticWorldPosition);
			set => SetProperty(ref _staticWorldPosition, value);
		}

		[Ordinal(5)] 
		[RED("fixedWorldOffset")] 
		public Vector4 FixedWorldOffset
		{
			get => GetProperty(ref _fixedWorldOffset);
			set => SetProperty(ref _fixedWorldOffset, value);
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public wCHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		public inkScreenProjectionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
