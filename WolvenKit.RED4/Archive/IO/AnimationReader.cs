using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class AnimationReader : IBufferReader
{
    private MemoryStream _ms;

    public AnimationReader(MemoryStream ms)
    {
        _ms = ms;
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.RootChunk is animAnimSet aas)
        {
            var animDataBuffers = new List<MemoryStream>();
            foreach (var chk in aas.AnimationDataChunks)
            {
                if (chk == null)
                {
                    throw new Exception("Invalid data in animAnimSet");
                }

                var ms = new MemoryStream();
                ms.Write(chk.Buffer.Buffer.GetBytes());

                animDataBuffers.Add(ms);
            }

            for (var i = 0; i < aas.Animations.Count; i++)
            {
                if (aas.Animations[i]?.GetValue() is animAnimSetEntry entry && entry.Animation.GetValue() is animAnimation animation)
                {
                    if (animation.AnimBuffer.GetValue() is animAnimationBufferCompressed animBuff)
                    {
                        if (animBuff.DataAddress != null && animBuff.InplaceCompressedBuffer == null && animBuff.DefferedBuffer == null)
                        {
                            //var defferedBuffer = new MemoryStream();
                            var dataAddr = animBuff.DataAddress;
                            var bytes = new byte[dataAddr.ZeInBytes];
                            animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                            animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Read(bytes, 0, (int)((uint)dataAddr.ZeInBytes));
                            animBuff.TempBuffer = new SerializationDeferredDataBuffer(bytes);
                        }
                        // super intensive, and not really needed in the GUI
                        //animBuff.ReadBuffer();
                    }
                }
            }
        }
        return EFileReadErrorCodes.NoError;
    }
}