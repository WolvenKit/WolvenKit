using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryKey : CVariable
	{
		private CUInt8 _pe;
		private CArrayFixedSize<CUInt8> _ta;

		[Ordinal(0)] 
		[RED("pe")] 
		public CUInt8 Pe
		{
			get
			{
				if (_pe == null)
				{
					_pe = (CUInt8) CR2WTypeManager.Create("Uint8", "pe", cr2w, this);
				}
				return _pe;
			}
			set
			{
				if (_pe == value)
				{
					return;
				}
				_pe = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ta", 12)] 
		public CArrayFixedSize<CUInt8> Ta
		{
			get
			{
				if (_ta == null)
				{
					_ta = (CArrayFixedSize<CUInt8>) CR2WTypeManager.Create("[12]Uint8", "ta", cr2w, this);
				}
				return _ta;
			}
			set
			{
				if (_ta == value)
				{
					return;
				}
				_ta = value;
				PropertySet(this);
			}
		}

		public physicsGeometryKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
