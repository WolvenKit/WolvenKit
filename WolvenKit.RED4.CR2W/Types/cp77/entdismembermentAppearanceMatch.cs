using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentAppearanceMatch : CVariable
	{
		private CName _character;
		private CName _mesh;
		private CBool _setByUser;

		[Ordinal(0)] 
		[RED("Character")] 
		public CName Character
		{
			get => GetProperty(ref _character);
			set => SetProperty(ref _character, value);
		}

		[Ordinal(1)] 
		[RED("Mesh")] 
		public CName Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(2)] 
		[RED("SetByUser")] 
		public CBool SetByUser
		{
			get => GetProperty(ref _setByUser);
			set => SetProperty(ref _setByUser, value);
		}

		public entdismembermentAppearanceMatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
