using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		private CFloat _rbfCoefficient;
		private CFloat _rbfPowValue;
		private CFloat _correctiveFrame;
		private CArray<animCorrectivePoseEntry> _correctives;

		[Ordinal(12)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get
			{
				if (_rbfCoefficient == null)
				{
					_rbfCoefficient = (CFloat) CR2WTypeManager.Create("Float", "rbfCoefficient", cr2w, this);
				}
				return _rbfCoefficient;
			}
			set
			{
				if (_rbfCoefficient == value)
				{
					return;
				}
				_rbfCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get
			{
				if (_rbfPowValue == null)
				{
					_rbfPowValue = (CFloat) CR2WTypeManager.Create("Float", "rbfPowValue", cr2w, this);
				}
				return _rbfPowValue;
			}
			set
			{
				if (_rbfPowValue == value)
				{
					return;
				}
				_rbfPowValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("correctiveFrame")] 
		public CFloat CorrectiveFrame
		{
			get
			{
				if (_correctiveFrame == null)
				{
					_correctiveFrame = (CFloat) CR2WTypeManager.Create("Float", "correctiveFrame", cr2w, this);
				}
				return _correctiveFrame;
			}
			set
			{
				if (_correctiveFrame == value)
				{
					return;
				}
				_correctiveFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("correctives")] 
		public CArray<animCorrectivePoseEntry> Correctives
		{
			get
			{
				if (_correctives == null)
				{
					_correctives = (CArray<animCorrectivePoseEntry>) CR2WTypeManager.Create("array:animCorrectivePoseEntry", "correctives", cr2w, this);
				}
				return _correctives;
			}
			set
			{
				if (_correctives == value)
				{
					return;
				}
				_correctives = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ApplyCorrectivePoseRBF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
