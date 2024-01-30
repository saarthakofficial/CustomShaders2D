# CustomShaders2D

![Unity Version](https://img.shields.io/badge/Unity-2019.4.18f1-blue.svg)
![URP Version](https://img.shields.io/badge/URP-7.3.1-blue.svg)

This repository contains custom 2D shaders created using Unity's Shader Graph in the Universal Render Pipeline (URP). Feel free to use and modify these shaders in your 2D projects to add unique visual effects.

## Shaders

### 1. Fire Projectile Shader

#### Features
- **Flame Texture**: A customizable flame texture.
- **Color Blend**: Adjust the blending of two colors for the flame.
- **Flame Scroll Speed**: Control the scrolling speed of the flame texture.
- **Noise**: Introduce noise for a more dynamic effect.
- **Dissolve Effect**: Control the dissolve effect on the flame.

#### Usage
1. Attach the shader to a 2D sprite in your scene.
2. Customize the flame texture, colors, and other parameters in the Shader Inspector.

```shader
Shader "Shader Graphs/Flames" {
    // ... (Shader code)
}
