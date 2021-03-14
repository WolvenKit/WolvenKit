using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTargetSetup : CVariable
	{
		private CStatic<CEnum<GpuWrapApieTextureFormat>> _rtFormats;
		private CEnum<GpuWrapApieTextureFormat> _dsFormat;

		[Ordinal(0)] 
		[RED("rtFormats", 8)] 
		public CStatic<CEnum<GpuWrapApieTextureFormat>> RtFormats
		{
			get
			{
				if (_rtFormats == null)
				{
					_rtFormats = (CStatic<CEnum<GpuWrapApieTextureFormat>>) CR2WTypeManager.Create("static:8,GpuWrapApieTextureFormat", "rtFormats", cr2w, this);
				}
				return _rtFormats;
			}
			set
			{
				if (_rtFormats == value)
				{
					return;
				}
				_rtFormats = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dsFormat")] 
		public CEnum<GpuWrapApieTextureFormat> DsFormat
		{
			get
			{
				if (_dsFormat == null)
				{
					_dsFormat = (CEnum<GpuWrapApieTextureFormat>) CR2WTypeManager.Create("GpuWrapApieTextureFormat", "dsFormat", cr2w, this);
				}
				return _dsFormat;
			}
			set
			{
				if (_dsFormat == value)
				{
					return;
				}
				_dsFormat = value;
				PropertySet(this);
			}
		}

		public PSODescRenderTargetSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
