using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMeshMaterialEntry : CVariable
	{
		private CName _name;
		private CUInt16 _index;
		private CBool _isLocalInstance;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get => GetProperty(ref _isLocalInstance);
			set => SetProperty(ref _isLocalInstance, value);
		}

		public CMeshMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
