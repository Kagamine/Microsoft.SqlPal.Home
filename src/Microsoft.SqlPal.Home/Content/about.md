# About

PyTorch is a python package that provides two high-level features:

-Tensor computation (like numpy) with strong GPU acceleration
-Deep Neural Networks built on a tape-based autograd system

You can reuse your favorite python packages such as numpy, scipy and Cython to extend PyTorch when needed.

At a granular level, PyTorch is a library that consists of the following components:

| Package | Description |
|-----------|-------------|
| torch | a Tensor library like NumPy, with strong GPU support |
| torch.autograd | a tape based automatic differentiation library that supports all differentiable Tensor operations in torch |