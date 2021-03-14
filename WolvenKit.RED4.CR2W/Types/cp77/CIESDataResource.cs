using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CIESDataResource : CResource
	{
		private CArrayFixedSize<CUInt8> _samples;

		[Ordinal(1)] 
		[RED("samples", 128)] 
		public CArrayFixedSize<CUInt8> Samples
		{
			get
			{
				if (_samples == null)
				{
					_samples = (CArrayFixedSize<CUInt8>) CR2WTypeManager.Create("[128]Uint8", "samples", cr2w, this);
				}
				return _samples;
			}
			set
			{
				if (_samples == value)
				{
					return;
				}
				_samples = value;
				PropertySet(this);
			}
		}

		public CIESDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
