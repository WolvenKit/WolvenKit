using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeContainer : CVariable
	{
		private CName _name;
		private CName _slotName;
		private CColor _color;
		private CHandle<gameIHitShape> _shape;
		private CHandle<gameHitShapeUserData> _userData;
		private physicsMaterialReference _physicsMaterial;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CHandle<gameIHitShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(5)] 
		[RED("physicsMaterial")] 
		public physicsMaterialReference PhysicsMaterial
		{
			get => GetProperty(ref _physicsMaterial);
			set => SetProperty(ref _physicsMaterial, value);
		}

		public gameHitShapeContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
