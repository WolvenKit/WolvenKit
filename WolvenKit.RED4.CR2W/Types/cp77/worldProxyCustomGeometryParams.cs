using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyCustomGeometryParams : CVariable
	{
		private CBool _useLimiterHelper;
		private CEnum<worldProxyMeshUVType> _uvType;

		[Ordinal(0)] 
		[RED("useLimiterHelper")] 
		public CBool UseLimiterHelper
		{
			get => GetProperty(ref _useLimiterHelper);
			set => SetProperty(ref _useLimiterHelper, value);
		}

		[Ordinal(1)] 
		[RED("uvType")] 
		public CEnum<worldProxyMeshUVType> UvType
		{
			get => GetProperty(ref _uvType);
			set => SetProperty(ref _uvType, value);
		}

		public worldProxyCustomGeometryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
