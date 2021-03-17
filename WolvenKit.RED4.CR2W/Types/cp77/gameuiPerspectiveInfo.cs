using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPerspectiveInfo : CVariable
	{
		private CName _name;
		private CName _fpp;
		private CName _tpp;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("fpp")] 
		public CName Fpp
		{
			get => GetProperty(ref _fpp);
			set => SetProperty(ref _fpp, value);
		}

		[Ordinal(2)] 
		[RED("tpp")] 
		public CName Tpp
		{
			get => GetProperty(ref _tpp);
			set => SetProperty(ref _tpp, value);
		}

		public gameuiPerspectiveInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
