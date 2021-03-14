using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendHistogramBias : CVariable
	{
		private Vector3 _mulCoef;
		private Vector3 _addCoef;

		[Ordinal(0)] 
		[RED("mulCoef")] 
		public Vector3 MulCoef
		{
			get
			{
				if (_mulCoef == null)
				{
					_mulCoef = (Vector3) CR2WTypeManager.Create("Vector3", "mulCoef", cr2w, this);
				}
				return _mulCoef;
			}
			set
			{
				if (_mulCoef == value)
				{
					return;
				}
				_mulCoef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addCoef")] 
		public Vector3 AddCoef
		{
			get
			{
				if (_addCoef == null)
				{
					_addCoef = (Vector3) CR2WTypeManager.Create("Vector3", "addCoef", cr2w, this);
				}
				return _addCoef;
			}
			set
			{
				if (_addCoef == value)
				{
					return;
				}
				_addCoef = value;
				PropertySet(this);
			}
		}

		public rendHistogramBias(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
