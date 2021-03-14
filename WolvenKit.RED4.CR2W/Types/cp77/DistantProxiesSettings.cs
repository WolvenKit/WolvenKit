using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantProxiesSettings : IAreaSettings
	{
		private CFloat _distantProxiesEmissive;
		private CFloat _distantProxiesEmissiveHeight;
		private CFloat _distantProxiesEmissivePower;
		private CFloat _distantProxiesBboxzBlend;

		[Ordinal(2)] 
		[RED("distantProxiesEmissive")] 
		public CFloat DistantProxiesEmissive
		{
			get
			{
				if (_distantProxiesEmissive == null)
				{
					_distantProxiesEmissive = (CFloat) CR2WTypeManager.Create("Float", "distantProxiesEmissive", cr2w, this);
				}
				return _distantProxiesEmissive;
			}
			set
			{
				if (_distantProxiesEmissive == value)
				{
					return;
				}
				_distantProxiesEmissive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distantProxiesEmissiveHeight")] 
		public CFloat DistantProxiesEmissiveHeight
		{
			get
			{
				if (_distantProxiesEmissiveHeight == null)
				{
					_distantProxiesEmissiveHeight = (CFloat) CR2WTypeManager.Create("Float", "distantProxiesEmissiveHeight", cr2w, this);
				}
				return _distantProxiesEmissiveHeight;
			}
			set
			{
				if (_distantProxiesEmissiveHeight == value)
				{
					return;
				}
				_distantProxiesEmissiveHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distantProxiesEmissivePower")] 
		public CFloat DistantProxiesEmissivePower
		{
			get
			{
				if (_distantProxiesEmissivePower == null)
				{
					_distantProxiesEmissivePower = (CFloat) CR2WTypeManager.Create("Float", "distantProxiesEmissivePower", cr2w, this);
				}
				return _distantProxiesEmissivePower;
			}
			set
			{
				if (_distantProxiesEmissivePower == value)
				{
					return;
				}
				_distantProxiesEmissivePower = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distantProxiesBboxzBlend")] 
		public CFloat DistantProxiesBboxzBlend
		{
			get
			{
				if (_distantProxiesBboxzBlend == null)
				{
					_distantProxiesBboxzBlend = (CFloat) CR2WTypeManager.Create("Float", "distantProxiesBboxzBlend", cr2w, this);
				}
				return _distantProxiesBboxzBlend;
			}
			set
			{
				if (_distantProxiesBboxzBlend == value)
				{
					return;
				}
				_distantProxiesBboxzBlend = value;
				PropertySet(this);
			}
		}

		public DistantProxiesSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
