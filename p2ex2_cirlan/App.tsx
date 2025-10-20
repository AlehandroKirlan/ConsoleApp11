import React from 'react';
import {StyleSheet, View} from 'react-native';

const Flex = () => {
  return (
    <View
      style={[
        styles.container,
        {
          flexDirection: 'column',
        },
      ]}>
      <View style={{flex: 3, backgroundColor: '#EF3340'}} />
      <View style={{flex: 2, backgroundColor: '#FFFFFF'}} />
      <View style={{flex: 3, backgroundColor: '#00A1DE'}} />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    aspectRatio: 5 / 3, // Соотношение 3:5 (высота:ширина)
    padding: 20,
  },
});

export default Flex;