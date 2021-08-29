using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentAppearanceMatch : RedBaseClass
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
	}
}
