using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DangleExternalInput : animAnimFeature
	{
		private Vector4 _fictitiousAccelerationWs;

		[Ordinal(0)] 
		[RED("fictitiousAccelerationWs")] 
		public Vector4 FictitiousAccelerationWs
		{
			get
			{
				if (_fictitiousAccelerationWs == null)
				{
					_fictitiousAccelerationWs = (Vector4) CR2WTypeManager.Create("Vector4", "fictitiousAccelerationWs", cr2w, this);
				}
				return _fictitiousAccelerationWs;
			}
			set
			{
				if (_fictitiousAccelerationWs == value)
				{
					return;
				}
				_fictitiousAccelerationWs = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_DangleExternalInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
