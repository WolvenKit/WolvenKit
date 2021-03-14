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
			get
			{
				if (_useLimiterHelper == null)
				{
					_useLimiterHelper = (CBool) CR2WTypeManager.Create("Bool", "useLimiterHelper", cr2w, this);
				}
				return _useLimiterHelper;
			}
			set
			{
				if (_useLimiterHelper == value)
				{
					return;
				}
				_useLimiterHelper = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("uvType")] 
		public CEnum<worldProxyMeshUVType> UvType
		{
			get
			{
				if (_uvType == null)
				{
					_uvType = (CEnum<worldProxyMeshUVType>) CR2WTypeManager.Create("worldProxyMeshUVType", "uvType", cr2w, this);
				}
				return _uvType;
			}
			set
			{
				if (_uvType == value)
				{
					return;
				}
				_uvType = value;
				PropertySet(this);
			}
		}

		public worldProxyCustomGeometryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
