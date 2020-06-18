using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[REDMeta()]
	public class SSeedKeyValue : CVariable
	{
		[RED("key")] 		public CUInt32 Key { get; set;}

		[RED("val")] 		public CUInt32 Val { get; set;}

		public SSeedKeyValue(CR2WFile cr2w) : base(cr2w){ }
		public override CVariable Create(CR2WFile cr2w) => new SSeedKeyValue(cr2w);

	}
}