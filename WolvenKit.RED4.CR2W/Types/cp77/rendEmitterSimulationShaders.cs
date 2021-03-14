using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendEmitterSimulationShaders : CVariable
	{
		private CArrayFixedSize<DataBuffer> _simCS;

		[Ordinal(0)] 
		[RED("simCS", 2)] 
		public CArrayFixedSize<DataBuffer> SimCS
		{
			get
			{
				if (_simCS == null)
				{
					_simCS = (CArrayFixedSize<DataBuffer>) CR2WTypeManager.Create("[2]DataBuffer", "simCS", cr2w, this);
				}
				return _simCS;
			}
			set
			{
				if (_simCS == value)
				{
					return;
				}
				_simCS = value;
				PropertySet(this);
			}
		}

		public rendEmitterSimulationShaders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
